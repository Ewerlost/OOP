using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public class DeleteObjectCommand : ICommand
    {
        private List<object> _objects;
        private object _deletedObject;
        private int _index;

        public DeleteObjectCommand(List<object> objects, object deletedObject)
        {
            _objects = objects;
            _deletedObject = deletedObject;
            _index = _objects.IndexOf(deletedObject);
        }

        public void Execute()
        {
            _objects.Remove(_deletedObject);
        }

        public void Undo()
        {
            if (_index >= 0 && _index <= _objects.Count)
                _objects.Insert(_index, _deletedObject);
            else
                _objects.Add(_deletedObject);
        }
    }
}
