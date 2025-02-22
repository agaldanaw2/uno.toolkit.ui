﻿using System;
using System.Collections.Generic;
using System.Text;
using Uno.Toolkit.Samples.Entities;
#if IS_WINUI
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
#else
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
#endif

namespace Uno.Toolkit.Samples
{
	public partial class SamplePageLayout
	{
		#region Property: Title

		public static DependencyProperty TitleProperty { get; } = DependencyProperty.Register(
			nameof(Title),
			typeof(string),
			typeof(SamplePageLayout),
			new PropertyMetadata(default));

		public string Title
		{
			get => (string)GetValue(TitleProperty);
			set => SetValue(TitleProperty, value);
		}

		#endregion
		#region Property: Description

		public static DependencyProperty DescriptionProperty { get; } = DependencyProperty.Register(
			nameof(Description),
			typeof(string),
			typeof(SamplePageLayout),
			new PropertyMetadata(default));

		public string Description
		{
			get => (string)GetValue(DescriptionProperty);
			set => SetValue(DescriptionProperty, value);
		}

		#endregion
		#region Property: DocumentationLink

		public static DependencyProperty DocumentationLinkProperty { get; } = DependencyProperty.Register(
			nameof(DocumentationLink),
			typeof(string),
			typeof(SamplePageLayout),
			new PropertyMetadata(default));

		public string DocumentationLink
		{
			get => (string)GetValue(DocumentationLinkProperty);
			set => SetValue(DocumentationLinkProperty, value);
		}

		#endregion
		#region Property: Source

		public static DependencyProperty SourceProperty { get; } = DependencyProperty.Register(
			nameof(Source),
			typeof(SourceSdk?),
			typeof(SamplePageLayout),
			new PropertyMetadata(default));

		public SourceSdk? Source
		{
			get => (SourceSdk?)GetValue(SourceProperty);
			set => SetValue(SourceProperty, value);
		}

		#endregion
		#region Property: IsDesignAgnostic

		public static DependencyProperty IsDesignAgnosticProperty { get; } = DependencyProperty.Register(
			nameof(IsDesignAgnostic),
			typeof(bool),
			typeof(SamplePageLayout),
			new PropertyMetadata(default(bool)));

		public bool IsDesignAgnostic
		{
			get => (bool)GetValue(IsDesignAgnosticProperty);
			set => SetValue(IsDesignAgnosticProperty, value);
		}

		#endregion

		#region Property: HeaderTemplate
		/// <summary>
		/// The Header is the part above the design tabs (Material|Fluent|Native).
		/// It contains the Description and the Source in the default style.
		/// </summary>
		public DataTemplate HeaderTemplate
		{
			get { return (DataTemplate)GetValue(HeaderTemplateProperty); }
			set { SetValue(HeaderTemplateProperty, value); }
		}

		public static readonly DependencyProperty HeaderTemplateProperty =
			DependencyProperty.Register("HeaderTemplate", typeof(DataTemplate), typeof(SamplePageLayout), new PropertyMetadata(null));
		#endregion

		#region Property: CupertinoTemplate

		public static DependencyProperty CupertinoTemplateProperty { get; } = DependencyProperty.Register(
			nameof(CupertinoTemplate),
			typeof(DataTemplate),
			typeof(SamplePageLayout),
			new PropertyMetadata(default));

		public DataTemplate CupertinoTemplate
		{
			get => (DataTemplate)GetValue(CupertinoTemplateProperty);
			set => SetValue(CupertinoTemplateProperty, value);
		}

		#endregion
		#region Property: MaterialTemplate

		public static DependencyProperty MaterialTemplateProperty { get; } = DependencyProperty.Register(
			nameof(MaterialTemplate),
			typeof(DataTemplate),
			typeof(SamplePageLayout),
			new PropertyMetadata(default));

		public DataTemplate MaterialTemplate
		{
			get => (DataTemplate)GetValue(MaterialTemplateProperty);
			set => SetValue(MaterialTemplateProperty, value);
		}

		#endregion
		#region Property: M3MaterialTemplate

		public static DependencyProperty M3MaterialTemplateProperty { get; } = DependencyProperty.Register(
			nameof(M3MaterialTemplate),
			typeof(DataTemplate),
			typeof(SamplePageLayout),
			new PropertyMetadata(default));

		public DataTemplate M3MaterialTemplate
		{
			get => (DataTemplate)GetValue(M3MaterialTemplateProperty);
			set => SetValue(M3MaterialTemplateProperty, value);
		}

		#endregion
		#region Property: DesignAgnosticTemplate

		public static DependencyProperty DesignAgnosticTemplateProperty { get; } = DependencyProperty.Register(
			nameof(DesignAgnosticTemplate),
			typeof(DataTemplate),
			typeof(SamplePageLayout),
			new PropertyMetadata(default(DataTemplate)));

		public DataTemplate DesignAgnosticTemplate
		{
			get => (DataTemplate)GetValue(DesignAgnosticTemplateProperty);
			set => SetValue(DesignAgnosticTemplateProperty, value);
		}

		#endregion
	}
}
