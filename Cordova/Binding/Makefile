XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
PROJECT_ROOT=incubator-cordova-ios/CordovaLib
PROJECT=$(PROJECT_ROOT)/CordovaLib.xcodeproj
TARGET=CordovaLib

all: Cordova.dll

incubator-cordova-ios:
	git clone https://github.com/apache/incubator-cordova-ios.git

libCordova-i386.a: incubator-cordova-ios
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release -arch i386 clean build
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/libCordova.a $@

libCordova-arm.a: incubator-cordova-ios
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/libCordova.a $@

libCordova.a: libCordova-i386.a libCordova-arm.a
	lipo -create -output $@ $^

Cordova.dll: Cordova.cs Makefile AssemblyInfo.cs libCordova.a
	/Developer/MonoTouch/usr/bin/btouch -e Cordova.cs AssemblyInfo.cs --out=$@ --link-with=libCordova.a,libCordova.a

clean:
	-rm -f *.a *dll
