using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public class ChangePropertyCommand : ICommand
    {
        private object _target;
        private PropertyInfo _property;
        private object _oldValue;
        private object _newValue;

        public ChangePropertyCommand(object target, string propertyName, object newValue)
        {
            _target = target;
            _property = target.GetType().GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
            _oldValue = _property.GetValue(target);
            _newValue = newValue;
        }

        public void Execute() => _property.SetValue(_target, _newValue);
        public void Undo() => _property.SetValue(_target, _oldValue);
    }
}
