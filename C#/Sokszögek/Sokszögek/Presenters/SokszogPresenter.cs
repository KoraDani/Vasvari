﻿using Sokszögek.Models;
using Sokszögek.Properties;
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
        private ISokszogView view;
        private SokszogRepo repo;
        private string kijelolSokszog;
        public bool oldalBLetezik, oldalCLetezik;
        public SokszogPresenter(ISokszogView param)
        {
            view = param;
            repo = new SokszogRepo();
        }
        public void LoadData()
        {
            view.SokszogList = repo.GetSokszogek();
        }

        public void GetSokszogType(int index)
        {
            kijelolSokszog = repo.GetNameByIndex(index);
            switch (kijelolSokszog)
            {
                case "Négyzet":
                    oldalBLetezik = false;
                    oldalCLetezik = false;
                    break;
                case "Téglalap":
                    oldalBLetezik = true;
                    oldalCLetezik = false;
                    break;
                case "Háromszög":
                    oldalBLetezik = true;
                    oldalCLetezik = true;
                    break;
                default:
                    oldalBLetezik = false;
                    oldalCLetezik = false;
                    break;
            }
        }

        public void Calculate()
        {
            view.errorOldalA = null;
            view.errorOldalB = null;
            switch (kijelolSokszog)
            {
                case "Négyzet":
                    double A = 0;
                    double.TryParse(view.oldalA, out A);
                    if (A > 0)
                    {
                        var negyzet = new Negyzet(A);
                        view.Kerulet = negyzet.Kerulet().ToString();
                        view.Terulet = negyzet.Terulet().ToString();
                    }
                    else
                    {
                        view.errorOldalA = Resources.KisebbEgyenlo0;
                        view.errorOldalB = Resources.KisebbEgyenlo0;
                    }
                    break;
                case "Téglalap":
                    double B = 0;
                    double.TryParse(view.oldalA, out A);
                    double.TryParse(view.oldalB, out B);
                    if (A> 0 && B > 0)
                    {
                        var teglalap = new Teglalap(A,B);
                        view.Kerulet = teglalap.Kerulet().ToString();
                        view.Terulet = teglalap.Terulet().ToString();
                    }
                    else if (A <= 0 && B <= 0)
                    {
                        view.errorOldalA = Resources.KisebbEgyenlo0;
                        view.errorOldalB = Resources.KisebbEgyenlo0;
                    }
                    else if (A <= 0)
                    {
                        view.errorOldalA = Resources.KisebbEgyenlo0;
                    }
                    else if (B<=0)
                    {
                        view.errorOldalB = Resources.KisebbEgyenlo0;
                    }
                    break;
                case "Háromszög":
                    double C = 0;
                    double.TryParse(view.oldalA, out A);
                    double.TryParse(view.oldalB, out B);
                    double.TryParse(view.oldalC, out C);
                    if (A > 0 && B > 0 && C > 0)
                    {
                        var haromszog = new Haromszog(A, B, C);
                        view.Kerulet = haromszog.Kerulet().ToString();
                        view.Terulet = haromszog.Terulet().ToString();
                    }
                    else
                    {
                        view.errorOldalC = Resources.KisebbEgyenlo0;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
