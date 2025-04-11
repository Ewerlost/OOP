using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public class CreateObjectCommand : ICommand
    {
        private List<object> _objects;
        private object _createdObject;

        public CreateObjectCommand(List<object> objects, object createdObject)
        {
            _objects = objects;
            _createdObject = createdObject;
        }

        public void Execute()
        {
            if (!_objects.Contains(_createdObject))
                _objects.Add(_createdObject);
        }

        public void Undo()
        {
            if (_objects.Contains(_createdObject))
                _objects.Remove(_createdObject);
        }
    }
}
