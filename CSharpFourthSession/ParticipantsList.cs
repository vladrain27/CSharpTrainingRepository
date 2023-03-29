
using static System.Formats.Asn1.AsnWriter;

namespace CSharpFourthSession
{
    internal class ParticipantsList
    {
        public List<Participant> Participants { get; set; }

        public ParticipantsList()
        {
            Participants = new List<Participant>();
        }

        public void PrintAllTheList()
        {
            foreach (var participant in Participants)
            {
                Console.WriteLine("Identification number: {0} Name: {1} Score: {2}", participant.IdentificationNumber, participant.Name, participant.Score);
            }
        }

        public void AddToTheEndOfTheList(Participant participant)
        {
            Participants.Add(participant);
        }

        public void AddToAGivenPosition(Participant participant, int position)
        {
            if (position > Participants.Count)
            {
                Console.WriteLine("Position is larger than list size");
                return;
            }
            Participants[position] = participant;
        }

        public void DeleteFromAGivenPosition(int position)
        {
            if (position > Participants.Count)
            {
                Console.WriteLine("Position {0} is higher than list size.", position);
                return;
            }
            Participants.RemoveAt(position);
        }

        public void ModifyScore(int identificationNumber, int modifiedScore)
        {
            var participant = Participants.Find(x => x.IdentificationNumber.Equals(identificationNumber));
            if (participant == null)
            {
                Console.WriteLine("Participant with this identification number does not exist.");
                return;
            }

            participant.Score = modifiedScore;
        }

        public void PrintParticipantsWithScoreLessThan(int score) 
        {
            Console.WriteLine("The participants with score lower that {0} are: ", score);
            foreach (var participant in Participants) 
            { 
                if (participant.Score < score)
                {
                    Console.WriteLine("Identification number: {0} Name: {1} Score: {2}", participant.IdentificationNumber, participant.Name, participant.Score);
                }
            }
        }

        public void PrintParticipantsInAscendingOrderByScore()
        {
            Console.WriteLine("The participants displayed in ascending order by score");
            List<Participant> orderedList = Participants.OrderBy(p => p.Score).ToList();
            foreach (var participant in orderedList)
            {
                Console.WriteLine("Identification number: {0} Name: {1} Score: {2}", participant.IdentificationNumber, participant.Name, participant.Score);
            }
        }

        public void PrintParticipantsInASpecificWay(int score)
        {
            Console.WriteLine("The participants with score higher than {0} sorted by asceding order", score);
            List<Participant> orderedList = Participants.OrderBy(p => p.Score).ToList();
            foreach (var participant in orderedList)
            {
                if (participant.Score > score)
                {
                    Console.WriteLine("Identification number: {0} Name: {1} Score: {2}", participant.IdentificationNumber, participant.Name, participant.Score);
                }
            }
        }

        public int CalculateArithmeticScore(int firstNumber, int secondNumber)
        {
            int sum = 0;
            for (int index = firstNumber; index <= secondNumber; index++)
            {
                sum = sum + Participants[index].Score;
            }

            return sum / (secondNumber - firstNumber);
        }
    }
}
