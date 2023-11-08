using System.Net;
using System.Text.Json;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Customer.API.Model;
using constant = Customer.API.Constants.Constants;
using Document = Amazon.DynamoDBv2.DocumentModel.Document;

namespace Customer.API.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IAmazonDynamoDB _dynamoDB;

		public CustomerRepository(IAmazonDynamoDB dynamoDB)
		{
            _dynamoDB = dynamoDB;
		}

        public async Task<bool> CreateAsync(CustomerModel customer)
        {
            customer.UpdatedAt = DateTime.UtcNow;
            customer.id = Guid.NewGuid();
            

            var itemRequest = CreatePutItemRequest(customer);

            var res = await _dynamoDB.PutItemAsync(itemRequest);
            
            return res.HttpStatusCode == HttpStatusCode.OK;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var itemRequest = CreateDeleteItemRequest(id);

            var res = await _dynamoDB.DeleteItemAsync(itemRequest);

            return res.HttpStatusCode == HttpStatusCode.OK;
        }

        public Task<IEnumerable<CustomerModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<CustomerModel?> GetAsync(Guid id)
        {

            var itemRequest = CreateGetItemRequest(id);
            var res = await _dynamoDB.GetItemAsync(itemRequest);

            if (res.Item.Count == 0) return null;

            var itemAsDocument = Document.FromAttributeMap(res.Item);

            return JsonSerializer.Deserialize<CustomerModel>(itemAsDocument);
        }

        public async Task<bool> UpdateAsync(CustomerModel customer)
        {
            customer.UpdatedAt = DateTime.UtcNow;
           

            var itemRequest = CreatePutItemRequest(customer);

            var res = await _dynamoDB.PutItemAsync(itemRequest);

            return res.HttpStatusCode == HttpStatusCode.OK;
        }


        private GetItemRequest CreateGetItemRequest(Guid Id)
        {
            var itemRequest = new GetItemRequest
            {
                TableName = constant.TableName,
                Key = new Dictionary<string, AttributeValue>
                {
                    { "pk", new AttributeValue{ S = Id.ToString() }  },
                    { "sk", new AttributeValue{ S = Id.ToString() }  },
                }
            };

            return itemRequest;
        }


        private PutItemRequest CreatePutItemRequest(CustomerModel customer)
        {
            var customerAsJsonFormat = JsonSerializer.Serialize(customer);
            var item = Document.FromJson(customerAsJsonFormat).ToAttributeMap();
            

            var itemRequest = new PutItemRequest
            {
                TableName = constant.TableName,
                Item = item,
                
            };

            return itemRequest;
        }


        private DeleteItemRequest CreateDeleteItemRequest(Guid Id)
        {
          
            var itemRequest = new DeleteItemRequest
            {
                TableName = constant.TableName,
                Key = new Dictionary<string, AttributeValue>
                {
                    { "pk", new AttributeValue{ S = Id.ToString() }  },
                    { "sk", new AttributeValue{ S = Id.ToString() }  },
                }
            };

            return itemRequest;
        }
    }
}

