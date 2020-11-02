using Sokszögek.Repositories;
using Sokszögek.ViewsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszögek.Presenters
{
    class SokszogPresenter
    {
        ISokszogView view;
        SokszogRepo repo;
        public SokszogPresenter(ISokszogView param)
        {
            view = param;
            repo = new SokszogRepo();
        }
        public void LoadData()
        {
            view.SokszogList = repo.GetSokszogek();
        }
    }
}
