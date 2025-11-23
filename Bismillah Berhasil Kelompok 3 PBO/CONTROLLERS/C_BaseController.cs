using System;
using SuwarSuwirApp.Models;

namespace SuwarSuwirApp.Controllers
{
    // Base controller menampung view reference (object) dan factory db
    public class C_BaseController
    {
        public object view;
        public M_DbContextFactory dbFactory;

        public C_BaseController(M_DbContextFactory factory)
        {
            dbFactory = factory;
        }

        public void SetView(object v)
        {
            view = v;
        }

        public void ShowView()
        {
            // implementasi view show di UI (dipanggil oleh view sendiri)
        }

        public void CloseView()
        {
            // implementasi close view (UI)
        }
    }
}
