using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schumacher
{
    class Eredmenyek
    {
        private string datum, grandprix, team, status;
        private int position, laps, points;

        public Eredmenyek (string sor)
        {
            string[] d = sor.Split(';');
            datum = d[0];
            grandprix = d[1];
            position = Convert.ToInt32(d[2]);
            laps = Convert.ToInt32(d[3]);
            points = Convert.ToInt32(d[4]);
            team = d[5];
            status = d[6];
        }

        public string Datum { get => datum; set => datum = value; }
        public string Grandprix { get => grandprix; set => grandprix = value; }
        public string Team { get => team; set => team = value; }
        public string Status { get => status; set => status = value; }
        public int Position { get => position; set => position = value; }
        public int Laps { get => laps; set => laps = value; }
        public int Points { get => points; set => points = value; }
    }
}
