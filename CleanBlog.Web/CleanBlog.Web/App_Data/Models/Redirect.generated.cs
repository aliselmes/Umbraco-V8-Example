//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.15.0
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
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Redirect</summary>
	[PublishedModel("redirect")]
	public partial class Redirect : PublishedContentModel, IRedirectControls, IVisibilityControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.15.0")]
		public new const string ModelTypeAlias = "redirect";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.15.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.15.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.15.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Redirect, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Redirect(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Is Temporary Redirect: Tick this if you want this redirect to only be temporary
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.15.0")]
		[ImplementPropertyType("isTemporaryRedirect")]
		public virtual bool IsTemporaryRedirect => global::Umbraco.Web.PublishedModels.RedirectControls.GetIsTemporaryRedirect(this);

		///<summary>
		/// Link: Enter a link for this redirect
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.15.0")]
		[ImplementPropertyType("link")]
		public virtual global::Umbraco.Web.Models.Link Link => global::Umbraco.Web.PublishedModels.RedirectControls.GetLink(this);

		///<summary>
		/// Hide From XML Sitemap: Tick this if you want to hide this page from the XML sitemap
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.15.0")]
		[ImplementPropertyType("hideFromXMLSitemap")]
		public virtual bool HideFromXmlsitemap => global::Umbraco.Web.PublishedModels.VisibilityControls.GetHideFromXmlsitemap(this);

		///<summary>
		/// Umbraco Navi Hide: Tick this box if you want to hide this page from the navigation and from search results.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.15.0")]
		[ImplementPropertyType("umbracoNaviHide")]
		public virtual bool UmbracoNaviHide => global::Umbraco.Web.PublishedModels.VisibilityControls.GetUmbracoNaviHide(this);
	}
}
