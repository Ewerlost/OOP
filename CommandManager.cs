using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public class CommandManager
    {
        private Stack<ICommand> _undoStack = new();
        private Stack<ICommand> _redoStack = new();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _undoStack.Push(command);
            _redoStack.Clear();
        }

        public void Undo()
        {
            if (_undoStack.Any())
            {
                var cmd = _undoStack.Pop();
                cmd.Undo();
                _redoStack.Push(cmd);
            }
        }

        public void Redo()
        {
            if (_redoStack.Any())
            {
                var cmd = _redoStack.Pop();
                cmd.Execute();
                _undoStack.Push(cmd);
            }
        }
    }
}
