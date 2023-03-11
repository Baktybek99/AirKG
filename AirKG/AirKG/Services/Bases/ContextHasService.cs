using AirKG.Context;
using System;
using System.Threading.Tasks;

namespace AirKG.Services.Bases
{
    public class ContextHasService : IDisposable
    {
        protected AirKGDbContext Context { get; }

        protected ContextHasService(AirKGDbContext context)
        {
            Context = context;
        }

        protected async Task SaveChanges()
        {
            await Context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Context?.Dispose();
        }
    }
}
