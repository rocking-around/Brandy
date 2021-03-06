namespace Brandy.NHibernate
{
    using System.Linq;
    using Core;

    public abstract class NHibernateLinqQueryBase<TResult, TCriterion> : IQuery<TResult, TCriterion>
        where TCriterion : ICriterion
    {
        private readonly ILinqProvider linqProvider;

        protected NHibernateLinqQueryBase(ILinqProvider linqProvider)
        {
            this.linqProvider = linqProvider;
        }

        protected IQueryable<T> Query<T>()
        {
            return linqProvider.Query<T>();
        }

        public abstract TResult Ask(TCriterion criterion);
    }
}