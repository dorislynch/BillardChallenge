
# react-native-billard-challenge

## Getting started

`$ npm install react-native-billard-challenge --save`

### Mostly automatic installation

`$ react-native link react-native-billard-challenge`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-billard-challenge` and add `RNBillardChallenge.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNBillardChallenge.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNBillardChallengePackage;` to the imports at the top of the file
  - Add `new RNBillardChallengePackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-billard-challenge'
  	project(':react-native-billard-challenge').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-billard-challenge/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-billard-challenge')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNBillardChallenge.sln` in `node_modules/react-native-billard-challenge/windows/RNBillardChallenge.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Billard.Challenge.RNBillardChallenge;` to the usings at the top of the file
  - Add `new RNBillardChallengePackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNBillardChallenge from 'react-native-billard-challenge';

// TODO: What to do with the module?
RNBillardChallenge;
```
  