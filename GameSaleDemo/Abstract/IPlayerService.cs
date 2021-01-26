using GameSaleDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Abstract
{
    public interface IPlayerService
    {
        void Save(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
