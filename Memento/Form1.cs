using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento
{
    public partial class Form1 : Form
    {
        CurrencyState curState { get; set; }
        MementoHistory history;
        public Form1()
        {
            InitializeComponent();
            curState = new CurrencyState();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            curState.Currencies.Add(new Currency("Rub", float.Parse(RubText.Text)));
            curState.Currencies.Add(new Currency("Aud", float.Parse(AudText.Text)));
            history = new MementoHistory();
            history.History.Push(curState.CreateMoment());
            curState.Currencies.Clear();
        }

        private void RestoreBtn_Click(object sender, EventArgs e)
        {
            curState.RestoreMoment(history.History.Pop());
            RubText.Text = curState.Currencies.First<Currency>().Value.ToString();
            AudText.Text = curState.Currencies.Last<Currency>().Value.ToString();
        }
    }
}
