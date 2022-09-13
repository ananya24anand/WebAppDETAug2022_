using APIDemo.Models;

namespace APIDemo.Services
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

    }
}
