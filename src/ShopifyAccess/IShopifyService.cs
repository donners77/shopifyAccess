﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifyAccess.Models.Order;
using ShopifyAccess.Models.Product;
using ShopifyAccess.Models.ProductVariant;

namespace ShopifyAccess
{
	public interface IShopifyService
	{
		/// <summary>
		/// Get orders by date and fulfillment status
		/// </summary>
		/// <param name="status">Fulfillment_status. Shipped, partial, unshipped or any</param>
		/// <param name="dateFrom">created_at_min. Show orders created after date (format: 2008-01-01 03:00)</param>
		/// <param name="dateTo">created_at_max. Show orders created before date (format: 2008-01-01 03:00)</param>
		/// <returns>Orders collection</returns>
		ShopifyOrders GetOrders( ShopifyOrderStatus status, DateTime dateFrom, DateTime dateTo );

		/// <summary>
		/// Get shipped orders async
		/// </summary>
		/// <param name="dateFrom">created_at_min. Show orders created after date (format: 2008-01-01 03:00)</param>
		/// <param name="dateTo">created_at_max. Show orders created before date (format: 2008-01-01 03:00)</param>
		/// <param name="status">fulfillment_status. Shipped,partial, unshipped or any</param>
		Task< ShopifyOrders > GetOrdersAsync( ShopifyOrderStatus status, DateTime dateFrom, DateTime dateTo );

		/// <summary>
		/// Get all existing products
		/// </summary>
		/// <returns>Products with variants (inventory items)</returns>
		ShopifyProducts GetProducts();

		/// <summary>
		/// Get all existing products async
		/// </summary>
		/// <returns>Products with variants (inventory items)</returns>
		Task< ShopifyProducts > GetProductsAsync();

		/// <summary>
		/// Update variants (inventory items)
		/// </summary>
		void UpdateProductVariants( IEnumerable< ShopifyProductVariant > variants );

		/// <summary>
		/// Update variants (inventory items) async
		/// </summary>
		Task UpdateProductVariantsAsync( IEnumerable< ShopifyProductVariant > variants );
	}
}