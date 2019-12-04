using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOC_Day2
{
    public class CPU
    {
        int[] _program;
        public CPU(IEnumerable<int> program)
        {
            _program = program.ToArray();
        }

        public void Run()
        {
            for(int i = 0; i < _program.Count(); i += 4)
            {
                switch (_program[i])
                {
                    case 1:
                        Add(i + 1, i + 2, i + 3);
                        break;
                    case 2:
                        Multiply(i + 1, i + 2, i + 3);
                        break;
                    case 99:
                        PrintProgram();
                        return;
                    default:
                        throw new Exception();
                }
            }
        }

        private void PrintProgram()
        {
            foreach(var value in _program)
            {
                Console.WriteLine($"{value},");
            }
        }

        private void Multiply(int in1, int in2, int outpos)
        {
            _program[_program[outpos]] = _program[_program[in1]] * _program[_program[in2]];
        }

        private void Add(int in1, int in2, int outpos)
        {
            _program[_program[outpos]] = _program[_program[in1]] + _program[_program[in2]];
        }
    }
}
