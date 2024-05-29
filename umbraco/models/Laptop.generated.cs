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
	/// <summary>Laptop</summary>
	[PublishedModel("laptop")]
	public partial class Laptop : PublishedContentModel, IProductList
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		public new const string ModelTypeAlias = "laptop";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<Laptop, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public Laptop(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Brand Product
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("brandProduct")]
		public virtual string BrandProduct => this.Value<string>(_publishedValueFallback, "brandProduct");

		///<summary>
		/// Brand Prod
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("brandProd")]
		public virtual string BrandProd => global::Umbraco.Cms.Web.Common.PublishedModels.ProductList.GetBrandProd(this, _publishedValueFallback);

		///<summary>
		/// Content Banner
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contentBanner")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel ContentBanner => global::Umbraco.Cms.Web.Common.PublishedModels.ProductList.GetContentBanner(this, _publishedValueFallback);

		///<summary>
		/// DescriptionProduct
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("descriptionProduct")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString DescriptionProduct => global::Umbraco.Cms.Web.Common.PublishedModels.ProductList.GetDescriptionProduct(this, _publishedValueFallback);

		///<summary>
		/// Download File Specifications
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("downloadFileSpecifications")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent DownloadFileSpecifications => global::Umbraco.Cms.Web.Common.PublishedModels.ProductList.GetDownloadFileSpecifications(this, _publishedValueFallback);

		///<summary>
		/// filtersCustom
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("filtersCustom")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel FiltersCustom => global::Umbraco.Cms.Web.Common.PublishedModels.ProductList.GetFiltersCustom(this, _publishedValueFallback);

		///<summary>
		/// ImageProduct
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("imageProduct")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent ImageProduct => global::Umbraco.Cms.Web.Common.PublishedModels.ProductList.GetImageProduct(this, _publishedValueFallback);

		///<summary>
		/// In Stock
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[ImplementPropertyType("inStock")]
		public virtual bool InStock => global::Umbraco.Cms.Web.Common.PublishedModels.ProductList.GetInStock(this, _publishedValueFallback);

		///<summary>
		/// NameProduct
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("nameProduct")]
		public virtual string NameProduct => global::Umbraco.Cms.Web.Common.PublishedModels.ProductList.GetNameProduct(this, _publishedValueFallback);

		///<summary>
		/// PriceProduct
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[ImplementPropertyType("priceProduct")]
		public virtual int PriceProduct => global::Umbraco.Cms.Web.Common.PublishedModels.ProductList.GetPriceProduct(this, _publishedValueFallback);

		///<summary>
		/// Reference Product
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.0+3972538")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("referenceProduct")]
		public virtual string ReferenceProduct => global::Umbraco.Cms.Web.Common.PublishedModels.ProductList.GetReferenceProduct(this, _publishedValueFallback);
	}
}
