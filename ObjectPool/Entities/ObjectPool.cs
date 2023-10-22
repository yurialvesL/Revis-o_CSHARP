using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool.Entities
{
    public class ObjectPool< T>
    {
        private readonly ConcurrentQueue<T> _objetos;
        private readonly Func<T> _geradorObjetos;


        public ObjectPool(Func<T> objectGenerator)
        {
            _geradorObjetos = objectGenerator ?? throw new ArgumentNullException(nameof(objectGenerator));
            _objetos = new ConcurrentQueue<T>();
        }

        public T BuscarChave(TK chave) => _objetos.TryGetValue(chave, out T objeto) ? objeto : _geradorObjetos();

        public void AdicionarAtualizar(TK chave, T item) => _objetos.AddOrUpdate(chave, item, (k,t) => item);



        public T Remover(TK chave) => _objetos.TryRemove(chave, out T objeto) ? objeto : _geradorObjetos();

        public IEnumerable<KeyValuePair<TK, T>> Where(Func<KeyValuePair<TK, T>, bool> predicate) => _objetos.Where(predicate);

        public ICollection<T> ObterTodosClear() { var temp = _objetos.Values; _objetos.Clear(); return temp; }
        public KeyValuePair<TK, T> PrimeiroOuDefault() => (_objetos.FirstOrDefault());
        public bool HasObject() => _objetos.Count > 0;


        public ConcurrentDictionary<TK, T> ObterTodosObjetos() => _objetos;


        public bool ObjetoExiste(TK chave) => _objetos.TryGetValue(chave, out T objeto) ? true : false;
    }
}
