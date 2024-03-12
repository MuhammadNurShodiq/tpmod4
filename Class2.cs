using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod4_1302223054
{
    internal class Class2
    {
        public enum DoorState
        {
            Terkunci,
            Terbuka
        }

        public class DoorMachine
        {
            private DoorState _currentState;

            public DoorMachine()
            {
                _currentState = DoorState.Terkunci;
            }

            public void LockDoor()
            {
                if (_currentState == DoorState.Terbuka)
                {
                    Console.WriteLine("Pintu dikunci!");
                    _currentState = DoorState.Terkunci;
                }
            }

            public void UnlockDoor()
            {
                if (_currentState == DoorState.Terkunci)
                {
                    Console.WriteLine("Pintu tidak terkunci!");
                    _currentState = DoorState.Terbuka;
                }
            }

            public DoorState GetState()
            {
                return _currentState;
            }
        }

    }
}
