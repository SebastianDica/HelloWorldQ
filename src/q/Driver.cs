using System;
using System.Threading.Tasks;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace runBase
{
    class Driver
    {
        static async Task Main(string[] args)
        {
            using (var quanticSimulator = new QuantumSimulator())
            {
                await JeanCelQuantic.Run(quanticSimulator);
            }
        }
    }
}
