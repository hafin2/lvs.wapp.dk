//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	// Mixin content Type 1119 with alias "bannerImg"
	/// <summary>Banner img</summary>
	public partial interface IBannerImg : IPublishedContent
	{
		/// <summary>Banner</summary>
		IPublishedContent Banner { get; }

		/// <summary>bannerHead</summary>
		string BannerHead { get; }
	}

	/// <summary>Banner img</summary>
	[PublishedContentModel("bannerImg")]
	public partial class BannerImg : PublishedContentModel, IBannerImg
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "bannerImg";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BannerImg(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BannerImg, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Banner
		///</summary>
		[ImplementPropertyType("banner")]
		public IPublishedContent Banner
		{
			get { return GetBanner(this); }
		}

		/// <summary>Static getter for Banner</summary>
		public static IPublishedContent GetBanner(IBannerImg that) { return that.GetPropertyValue<IPublishedContent>("banner"); }

		///<summary>
		/// bannerHead
		///</summary>
		[ImplementPropertyType("bannerHead")]
		public string BannerHead
		{
			get { return GetBannerHead(this); }
		}

		/// <summary>Static getter for bannerHead</summary>
		public static string GetBannerHead(IBannerImg that) { return that.GetPropertyValue<string>("bannerHead"); }
	}
}
