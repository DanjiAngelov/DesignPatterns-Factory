using System;

namespace ChainOfResponsibility
{
    // Базов клас
    abstract class Approver
    {
        protected Approver nextApprover;

        public void SetNext(Approver nextApprover)
        {
            this.nextApprover = nextApprover;
        }

        public abstract void ProcessRequest(int amount);
    }

    // Manager
    class Manager : Approver
    {
        public override void ProcessRequest(int amount)
        {
            if (amount <= 1000)
            {
                Console.WriteLine($"Manager одобри разход: {amount} лв.");
            }
            else if (nextApprover != null)
            {
                nextApprover.ProcessRequest(amount);
            }
        }
    }

    // Director
    class Director : Approver
    {
        public override void ProcessRequest(int amount)
        {
            if (amount <= 5000)
            {
                Console.WriteLine($"Director одобри разход: {amount} лв.");
            }
            else if (nextApprover != null)
            {
                nextApprover.ProcessRequest(amount);
            }
        }
    }

    // CEO
    class CEO : Approver
    {
        public override void ProcessRequest(int amount)
        {
            Console.WriteLine($"CEO одобри разход: {amount} лв.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Approver manager = new Manager();
            Approver director = new Director();
            Approver ceo = new CEO();

            manager.SetNext(director);
            director.SetNext(ceo);

            manager.ProcessRequest(500);
            manager.ProcessRequest(3000);
            manager.ProcessRequest(10000);
        }
    }
}