﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public sealed class Session
    {
        public const string __pathPrefix = @"\data";
        public const string __dirPhoto = @"\photo";
        public const string __file404 = @"\data\404.jpg";
        public static Dictionary<Act, string> DTables = new Dictionary<Act, string>();
        //public Dictionary<Act, IMyTable> DClass = new Dictionary<Act, IMyTable>();
        //public Dictionary<Act, Type> DForm = new Dictionary<Act, Type>();
        public enum Act { Items,
                          Producers,
                          Storages,
                          Products,
                          Hardwares};
        public static Act currAct { get; set; }
        public static string _path { get; set; }
        public static Dictionary<Act, int> GridPosition = new Dictionary<Act, int>();

        private static readonly Session instance = new Session();

        public static Session Instance
        {
            get { return instance; }
        }

        private Session()
        {
            DTables.Add(Act.Items, "Items");
            DTables.Add(Act.Producers, "Producers");
            DTables.Add(Act.Storages, "Storages");
            DTables.Add(Act.Products, "Products");
            DTables.Add(Act.Hardwares, "Hardwares");
            foreach (Act _item in Enum.GetValues(typeof(Act)))
            {
                GridPosition.Add(_item, 0);
            }            
            //DClass.Add(Act.Items, null);
            //DClass.Add(Act.Producers, null);
            //DForm.Add(Act.Items, typeof(Items));
            //DForm.Add(Act.Producers, null);
        }

        public static Form ReturnActForm(int _id)
        {
            Form frm = null;
            if (Session.currAct == Session.Act.Producers)
            {
                frm = new FProducers(_id);
            }
            if (Session.currAct == Session.Act.Items)
            {
                frm = new FItems(_id);
            }
            if (Session.currAct == Session.Act.Storages)
            {
                frm = new FStorages(_id);
            }
            if (Session.currAct == Session.Act.Products)
            {
                frm = new FProducts(_id);
            }
            if (Session.currAct == Session.Act.Hardwares)
            {
                frm = new FHardwares(_id);
            }
            return frm;
        }

        public static IMyTable ReturnActTable()
        {
            IMyTable tbl = null;
            if (Session.currAct == Session.Act.Producers)
            {
                tbl = new producer();
            }
            if (Session.currAct == Session.Act.Items)
            {
                tbl = new Item();
            }
            if (Session.currAct == Session.Act.Storages)
            {
                tbl = new Storage();
            }
            if (Session.currAct == Session.Act.Products)
            {
                tbl = new Product();
            }
            if (Session.currAct == Session.Act.Hardwares)
            {
                tbl = new Hardware();
            }
            if (Session.currAct == Session.Act.Products)
            {
                tbl = new Product();
            }
            return tbl;
        }                       

        public static string ActToString()
        {
            return DTables[currAct];
        }

    }
}
