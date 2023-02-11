using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Northgard.Core.Data;
using Northgard.Enterprise.DataSets;
using Zenject;

namespace Northgard.Persistence.Repositories
{
    [UsedImplicitly]
    public class WorldRepository : IRepository<WorldDataset>
    {
        [Inject] private IDataTable<WorldDataset> _worldTable;
        public void Create(WorldDataset newItem)
        {
            _worldTable.Create(newItem);
        }

        public void Create(IEnumerable<WorldDataset> range)
        {
            _worldTable.Create(range);
        }

        public void CreateOrUpdate(WorldDataset item)
        {
            _worldTable.CreateOrUpdate(item);
        }

        public WorldDataset Read(string id)
        {
            return _worldTable.Read(id);
        }

        public IEnumerable<WorldDataset> Read()
        {
            return _worldTable.Read();
        }

        public IEnumerable<WorldDataset> Read(Predicate<WorldDataset> match)
        {
            return _worldTable.Read(match);
        }

        public void Delete(string id)
        {
            _worldTable.Delete(id);
        }

        public void Delete(Predicate<WorldDataset> match)
        {
            _worldTable.Delete(match);
        }

        public void Update(WorldDataset item)
        {
            _worldTable.Update(item);
        }

        public bool Exists(string id)
        {
            return _worldTable.Exists(id);
        }

        public void SaveChanges()
        {
            _worldTable.SaveChanges();
        }
    }
}