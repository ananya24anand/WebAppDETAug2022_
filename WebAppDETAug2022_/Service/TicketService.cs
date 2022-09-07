using System.Xml.Linq;
using WebAppDETAug2022_.Models;

namespace WebAppDETAug2022_.Service
{
    public class TicketService
    {

        static List<Ticket> Tickets { get; }
        static int nextId = 3;
        static TicketService()
        {
            Tickets = new List<Ticket>
                {
                    new Ticket { Id = 1, Name = "Movie 1", Price=200},
                    new Ticket { Id = 2, Name = "Movie 2", Price=1500 }
                };
        }

        public static List<Ticket> GetAll() => Tickets;

        public static Ticket? Get(int id) => Tickets.FirstOrDefault(t => t.Id == id);

        public static void Add(Ticket ticket)
        {
            ticket.Id = nextId++;
            Tickets.Add(ticket);
        }

        public static void Delete(int id)
        {
            var ticket = Get(id);
            if (ticket is null)
                return;

            Tickets.Remove(ticket);
        }

        public static void Update(Ticket ticket)
        {
            var index = Tickets.FindIndex(p => p.Id == ticket.Id);
            if (index == -1)
                return;

            Tickets[index] = ticket;
        }
    }
}
