//
//  Copyright 2012  Scott Blomquist
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreLocation;

namespace Cordova
{
	[BaseType (typeof (UIViewController))]
	interface CDVViewController {
		[Export ("webView")]
		CDVCordovaView WebView { get; set; }

		[Export ("pluginObjects")]
		NSMutableDictionary PluginObjects { get; }

		[Export ("pluginsMap")]
		NSDictionary PluginsMap { get; }

		[Export ("settings")]
		NSDictionary Settings { get; }

		[Export ("whiteList")]
		CDVWhitelist WhiteList { get; }

		[Export ("supportedOrientations")]
		NSArray SupportedOrientations { get; }

		[Export ("loadFromString")]
		bool LoadFromString { get; }

		[Export ("useSplashScreen")]
		bool UseSplashScreen { get; set; }

		[Export ("activityView")]
		UIActivityIndicatorView ActivityView { get; }

		[Export ("imageView")]
		UIImageView ImageView { get; }

		[Export ("commandDelegate")]
		NSObject CommandDelegate { get; set; }

		[Export ("wwwFolderName")]
		string WwwFolderName { get; set; }

		[Export ("startPage")]
		string StartPage { get; set; }

		[Export ("printMultitaskingInfo")]
		void PrintMultitaskingInfo ();

		[Export ("createGapView")]
		void CreateGapView ();

		[Export ("newCordovaViewWithFrame:")]
		CDVCordovaView NewCordovaView(RectangleF bounds);

		[Export ("executeQueuedCommands")]
		int ExecuteQueuedCommands ();

		[Export ("flushCommandQueue")]
		void FlushCommandQueue();

		[Export ("javascriptAlert:")]
		void JavascriptAlert (string text);

		[Export ("appURLScheme")]
		string AppUrlScheme ();

		[Export ("parseInterfaceOrientations:")]
		NSArray ParseInterfaceOrientations (NSArray orientations);

		[Static] [Export ("getBundlePlist:")]
		NSDictionary GetBundlePlist (string plistName);

		[Static] [Export ("applicationDocumentsDirectory")]
		string ApplicationDocumentsDirectory ();
	}

	[BaseType (typeof(UIWebView))]
	interface CDVCordovaView {
	}

	[BaseType (typeof(NSObject))]
	interface CDVWhitelist {
		[Export ("whitelist")]
		NSArray Whitelist { get; }

		[Export ("expandedWhitelist")]
		NSArray ExpandedWhitelist { get; }

		[Export ("allowAll")]
		bool AllowAll { get; }

		[Export ("initWithArray:")]
		IntPtr Constructor (NSArray array);

		[Export ("URLIsAllowed:")]
		bool UrlIsAllowed (NSUrl url);

		[Export ("schemeIsAllowed:")]
		bool SchemeIsAllowed (string scheme);

		[Export ("errorStringForURL:")]
		string ErrorStringForUrl (NSUrl url);
	}
}
