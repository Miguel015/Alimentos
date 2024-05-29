//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v10.1.0+3972538
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	// Mixin Content Type with alias "productList"
	/// <summary>ProductList</summary>
	public partial interface IProductList : IPublishedContent
	{
		/// <summary>Brand Prod</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string BrandProd { get; }

		/// <summary>Content Banner</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Models.Blocks.BlockListModel ContentBanner { get; }

		/// <summary>DescriptionProduct</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Strings.IHtmlEncodedString DescriptionProduct { get; }

		/// <summary>Download File Specifications</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent DownloadFileSpecifications { get; }

		/// <summary>filtersCustom</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Models.Blocks.BlockListModel FiltersCustom { get; }

		/// <summary>ImageProduct</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent ImageProduct { get; }

		/// <summary>In Stock</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		bool InStock { get; }

		/// <summary>NameProduct</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string NameProduct { get; }

		/// <summary>PriceProduct</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		int PriceProduct { get; }

		/// <summary>Reference Product</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string ReferenceProduct { get; }
	}

	/// <summary>ProductList</summary>
	[PublishedModel("productList")]
	public partial class ProductList : PublishedContentModel, IProductList
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		public new const string ModelTypeAlias = "productList";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<ProductList, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public ProductList(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Brand Prod
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("brandProd")]
		public virtual string BrandProd => GetBrandProd(this, _publishedValueFallback);

		/// <summary>Static getter for Brand Prod</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetBrandProd(IProductList that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "brandProd");

		///<summary>
		/// Content Banner
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contentBanner")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel ContentBanner => GetContentBanner(this, _publishedValueFallback);

		/// <summary>Static getter for Content Banner</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Models.Blocks.BlockListModel GetContentBanner(IProductList that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.Blocks.BlockListModel>(publishedValueFallback, "contentBanner");

		///<summary>
		/// DescriptionProduct
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("descriptionProduct")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString DescriptionProduct => GetDescriptionProduct(this, _publishedValueFallback);

		/// <summary>Static getter for DescriptionProduct</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Strings.IHtmlEncodedString GetDescriptionProduct(IProductList that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(publishedValueFallback, "descriptionProduct");

		///<summary>
		/// Download File Specifications
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("downloadFileSpecifications")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent DownloadFileSpecifications => GetDownloadFileSpecifications(this, _publishedValueFallback);

		/// <summary>Static getter for Download File Specifications</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent GetDownloadFileSpecifications(IProductList that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent>(publishedValueFallback, "downloadFileSpecifications");

		///<summary>
		/// filtersCustom
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("filtersCustom")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel FiltersCustom => GetFiltersCustom(this, _publishedValueFallback);

		/// <summary>Static getter for filtersCustom</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Models.Blocks.BlockListModel GetFiltersCustom(IProductList that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.Blocks.BlockListModel>(publishedValueFallback, "filtersCustom");

		///<summary>
		/// ImageProduct
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("imageProduct")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent ImageProduct => GetImageProduct(this, _publishedValueFallback);

		/// <summary>Static getter for ImageProduct</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent GetImageProduct(IProductList that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent>(publishedValueFallback, "imageProduct");

		///<summary>
		/// In Stock
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[ImplementPropertyType("inStock")]
		public virtual bool InStock => GetInStock(this, _publishedValueFallback);

		/// <summary>Static getter for In Stock</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		public static bool GetInStock(IProductList that, IPublishedValueFallback publishedValueFallback) => that.Value<bool>(publishedValueFallback, "inStock");

		///<summary>
		/// NameProduct
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("nameProduct")]
		public virtual string NameProduct => GetNameProduct(this, _publishedValueFallback);

		/// <summary>Static getter for NameProduct</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetNameProduct(IProductList that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "nameProduct");

		///<summary>
		/// PriceProduct
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[ImplementPropertyType("priceProduct")]
		public virtual int PriceProduct => GetPriceProduct(this, _publishedValueFallback);

		/// <summary>Static getter for PriceProduct</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		public static int GetPriceProduct(IProductList that, IPublishedValueFallback publishedValueFallback) => that.Value<int>(publishedValueFallback, "priceProduct");

		///<summary>
		/// Reference Product
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("referenceProduct")]
		public virtual string ReferenceProduct => GetReferenceProduct(this, _publishedValueFallback);

		/// <summary>Static getter for Reference Product</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetReferenceProduct(IProductList that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "referenceProduct");
	}
}
