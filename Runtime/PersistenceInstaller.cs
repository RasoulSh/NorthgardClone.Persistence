using Northgard.Core.Data;
using Northgard.Enterprise.DataSets;
using Northgard.Persistence.Repositories;
using Zenject;

namespace Northgard.Persistence
{
    public class PersistenceInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IRepository<WorldDataset>>().To<WorldRepository>().FromNew().AsSingle();
        }
    }
}