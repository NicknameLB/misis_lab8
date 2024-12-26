using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static misis_lab8.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace misis_lab8
{
    public partial class Form1 : Form
    {
        private static System.Timers.Timer washTimer;
        StateMachine machine = new StateMachine();
        bool doorOpen = false;

        public Form1()
        {
            InitializeComponent();
            machine.InitializeStates();
            UpdateUI();
        }

        public enum ProcessState
        {
            Off,
            Active,
            Idle
        }

        public enum Command
        {
            Begin,
            End
        }

        public class StateMachine
        {
            class StateTransition
            {
                readonly ProcessState CurrentState;
                readonly Command Command;

                public override int GetHashCode()
                {
                    return CurrentState.GetHashCode() ^ Command.GetHashCode();
                }

                public StateTransition(ProcessState currentState, Command command)
                {
                    CurrentState = currentState;
                    Command = command;
                }
            }
            Dictionary<StateTransition, ProcessState> transitions;
            public ProcessState CurrentState { get; private set; }

            public void InitializeStates()
            {
                CurrentState = ProcessState.Off;
                transitions = new Dictionary<StateTransition, ProcessState>
            {
                { new StateTransition(ProcessState.Off, Command.Begin), ProcessState.Idle },
                { new StateTransition(ProcessState.Idle, Command.End) , ProcessState.Off },
                { new StateTransition(ProcessState.Idle, Command.Begin), ProcessState.Active },
                { new StateTransition(ProcessState.Active, Command.End) , ProcessState.Idle }
            };
            }



            public ProcessState GetNext(Command command)
            {
                StateTransition transition = new StateTransition(CurrentState, command);
                ProcessState nextState = CurrentState;
                foreach (KeyValuePair <StateTransition, ProcessState> tr in transitions)
                {
                    if (tr.Key.GetHashCode() == transition.GetHashCode())
                    {
                        nextState = tr.Value;
                    }
                }
                return nextState;
            }

            public ProcessState MoveNext(Command command)
            {
                CurrentState = GetNext(command);
                return CurrentState;
            }
        }

        private void btnPower_Click(object sender, EventArgs e)
        {   
            if (!chkWater.Checked)
            {
                MessageBox.Show("Add water!\n");
            }
            else if (!chkPowder.Checked)
            {
                MessageBox.Show("Add powder!\n");
            }
            else if (!chkDetergent.Checked)
            {
                MessageBox.Show("Add detergent!\n");
            }
            else if (machine.CurrentState == ProcessState.Idle)
            {

                machine.MoveNext(Command.End);
            }
            else 
            {
                machine.MoveNext(Command.Begin);
            }
            UpdateUI();
        }

        private void btnDoor_Click(object sender, EventArgs e)
        {
            doorOpen = !doorOpen; // Toggle door status
            UpdateUI();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!chkClothes.Checked)
            {
                MessageBox.Show("Add clothes!\n");
            }
            else if (doorOpen)
            {
                MessageBox.Show("Close door!\n");
            }
            else
            {
                machine.MoveNext(Command.Begin);
                UpdateUI();
                washTimer = new System.Timers.Timer(10000);
                washTimer.Elapsed += OnTimedEvent;
                washTimer.AutoReset = false;
                washTimer.Enabled = true;
            }
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            machine.MoveNext(Command.End);
            if (InvokeRequired)
            {
                this.Invoke(new Action(UpdateUI));
            }
            else
            {
                UpdateUI();
            }
        }

        private void UpdateUI()
        {
            btnDoor.Text = doorOpen ? "Close Door" : "Open Door";
            btnStart.Enabled = machine.CurrentState == ProcessState.Idle;
            rtbMessages.AppendText("Current state: " + machine.CurrentState + "\n");
            chkWater.Enabled = machine.CurrentState == ProcessState.Off;
            chkPowder.Enabled = machine.CurrentState == ProcessState.Off;
            chkDetergent.Enabled = machine.CurrentState == ProcessState.Off;
            chkClothes.Enabled = machine.CurrentState == ProcessState.Idle;
            btnDoor.Enabled = machine.CurrentState == ProcessState.Idle;
            btnPower.Enabled = machine.CurrentState == ProcessState.Idle || machine.CurrentState == ProcessState.Off;
        }
    }
}