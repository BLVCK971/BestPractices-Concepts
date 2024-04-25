using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPractices_Concepts.DesignPatterns.AbstractFactory.Factories;

internal interface IAbstractFactory
{
    IAbstract CreateProtocol();
    IAbstractModule CreateModule();
}
