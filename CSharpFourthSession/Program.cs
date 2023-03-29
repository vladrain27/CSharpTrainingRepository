using System;

namespace CSharpFourthSession
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var participantsList = new ParticipantsList();
            Random rand = new Random();
            for (int index = 1; index <= 95; index++)
            {
                string randomName = $@"{DateTime.Now.Ticks}";
                int randomScore = rand.Next(1, 100);
                var participant = new Participant() { Name = randomName, IdentificationNumber = index, Score = randomScore };
                participantsList.AddToTheEndOfTheList(participant);
            }

            var participant1 = new Participant() { Name = $@"{DateTime.Now.Ticks}", IdentificationNumber = 96, Score = rand.Next(1, 100) };
            var participant2 = new Participant() { Name = $@"{DateTime.Now.Ticks}", IdentificationNumber = 97, Score = rand.Next(1, 100) };
            var participant3 = new Participant() { Name = $@"{DateTime.Now.Ticks}", IdentificationNumber = 98, Score = rand.Next(1, 100) };
            var participant4 = new Participant() { Name = $@"{DateTime.Now.Ticks}", IdentificationNumber = 99, Score = rand.Next(1, 100) };
            var participant5 = new Participant() { Name = $@"{DateTime.Now.Ticks}", IdentificationNumber = 100, Score = rand.Next(1, 100) };

            participantsList.AddToAGivenPosition(participant1, 33);
            participantsList.AddToAGivenPosition(participant2, 55);
            participantsList.AddToAGivenPosition(participant3, 59);
            participantsList.AddToAGivenPosition(participant4, 1);
            participantsList.AddToAGivenPosition(participant5, 99);

            participantsList.DeleteFromAGivenPosition(rand.Next(1, 100));

            participantsList.ModifyScore(55, 44);

            participantsList.PrintParticipantsWithScoreLessThan(55);

            Console.WriteLine("\n");

            participantsList.PrintParticipantsInAscendingOrderByScore();

            Console.WriteLine("\n");

            participantsList.PrintParticipantsInASpecificWay(33);
        }
    }
}