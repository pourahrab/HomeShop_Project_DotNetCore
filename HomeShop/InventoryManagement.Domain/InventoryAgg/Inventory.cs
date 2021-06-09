using _0_Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Domain.InventoryAgg
{
    public class Inventory:EntityBase
    {
        public long ProductId { get; private set; }
        public double UnitPrice { get; private set; }
        public bool IsStock { get; private set; }
        public List<InventoryOperation> Operations { get; private set; }

        public Inventory(long productId, double unitPrice)
        {
            ProductId = productId;
            UnitPrice = unitPrice;
            IsStock = false;
        }

        public long CalculateCurrentCount()  // mohasebe mojodi feeli anbar
        {
            var plus = Operations.Where(x => x.Operation).Sum(x => x.Count); // sum where operation is true = vorodi
            var minus = Operations.Where(x => !x.Operation).Min(x => x.Count); // minus where operation is false = khoroji
            return plus - minus;
        }

        public void Increase(long count, long operatorId, string description)
        {
            var currentcount = CalculateCurrentCount() + count;
            var operation = new InventoryOperation(true,count,operatorId, currentcount, description, 0, Id);
            this.Operations.Add(operation);
            IsStock = currentcount > 0;  // if(currentcount>0) ==> IsStock = true  else(IsStock=false)
        }
        public void Reduce(long count, long operatorId, string description, long orderId)
        {
            var currentcount = CalculateCurrentCount() - count;
            var operation = new InventoryOperation(false, count, operatorId, currentcount, description, orderId, Id);
            this.Operations.Add(operation);
            IsStock = currentcount > 0;  // if(currentcount>0) ==> IsStock = true  else(IsStock=false)
        }
    }

    public class InventoryOperation
    {
        public long Id { get; private set; }
        public bool Operation { get; private set; }  // vorodi ya khoroji
        public long Count { get; private set; }
        public long OperatorId { get; private set; }
        public DateTime OperationDate { get; private set; }
        public long CurrentCount { get; private set; }
        public string Description { get; private set; }
        public long OrderId { get; private set; }
        public long InventoryId { get; private set; }
        public Inventory inventory { get; private set; }

        public InventoryOperation( bool operation, long count, long operatorId, long currentCount, string description, long orderId, long inventoryId)
        {
            Operation = operation;
            Count = count;
            OperatorId = operatorId;
            CurrentCount = currentCount;
            Description = description;
            OrderId = orderId;
            InventoryId = inventoryId;
        }
    } 
}
