using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libCordova.a", LinkTarget.Simulator | LinkTarget.ArmV6 | LinkTarget.ArmV7, ForceLoad = true, Frameworks = "AddressBook, AddressBookUI, AudioToolbox, AVFoundation, CoreLocation, MediaPlayer, QuartzCore, SystemConfiguration, MobileCoreServices, CoreMedia")]
