using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerosLogic
{
    public interface ISuperPowerRepo
    {
        void AddSuperPower(SuperPower superPower);
        IEnumerable<SuperPower> GetAllSuperPowers();
        SuperPower GetSuperPowerById(int id);
        void RemoveSuperPower(int id);
    }
}