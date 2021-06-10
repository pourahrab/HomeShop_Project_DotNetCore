using InventoryManagement.Application.Contract.Inventory;
using System;
using System.Collections.Generic;
using System.Threading;
using _0_Framework.Application;
using InventoryManagement.Domain.InventoryAgg;

namespace InventoryManagement.Application
{
    public class InventoryApplication : IInventoryApplication
    {
        private readonly IInventoryRepository _inventoryrepository;

        public InventoryApplication(IInventoryRepository inventoryrepository)
        {
            _inventoryrepository = inventoryrepository;
        }

        public OperationResult Create(CreateInventory command)
        {
            var operation = new OperationResult();
            if (_inventoryrepository.Exists(x => x.ProductId == command.ProductId))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);
            var inventory = new Inventory(command.ProductId,command.UnitPrice);
            _inventoryrepository.Create(inventory);
            _inventoryrepository.Save();
            return operation.Succeeded();

        }

        public OperationResult Edit(EditInventory command)
        {
            var operation = new OperationResult();
            var inventory = _inventoryrepository.GetById(command.Id);
            if (inventory == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            if (_inventoryrepository.Exists(x => x.ProductId == command.ProductId && x.Id != command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            inventory.Edit(command.ProductId,command.UnitPrice);
            _inventoryrepository.Save();
            return operation.Succeeded();
        }

        public OperationResult Increase(IncreaseInventory command)
        {
            var operation = new OperationResult();
            var inventory = _inventoryrepository.GetById(command.InventoryId);
            if (inventory == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            const long operatorId = 1;
            inventory.Increase(command.Count, operatorId, command.Description);
            _inventoryrepository.Save();
            return operation.Succeeded();
        }

        public OperationResult Reduce(ReduceInventory command)
        {
            var operation = new OperationResult();
            var inventory = _inventoryrepository.GetById(command.InventoryId);
            if (inventory == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            const long operatorId = 1;
            inventory.Reduce(command.Count, operatorId, command.Description,0);
            _inventoryrepository.Save();
            return operation.Succeeded();
        }

        public OperationResult Reduce(List<ReduceInventory> command)
        {
            var operation = new OperationResult();
            const long operatorId = 1;
            foreach (var item in command)
            {
                var inventory = _inventoryrepository.GetById(item.ProductId);
                inventory.Reduce(item.Count,operatorId,item.Description,item.OrderId);
            }
            _inventoryrepository.Save();
            return operation.Succeeded();
        }

        public EditInventory GetDetails(long id)
        {
            return _inventoryrepository.GetDetails(id);
        }

        public List<InventoryViewModel> Search(InventorySearchModel searchModel)
        {
            return _inventoryrepository.Search(searchModel);
        }
    }

  
}
