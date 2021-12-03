- General Questions:

	- Tabbed workflows? (rather than creating a new instance of the .exe for each workflow) + being able to move tabs around in editor?

	- Hosting video tutorials (e.g. Bonsai club): youtube?

		- < "Bonsai Rx" youtube channel >

	- How can you export workflows to the public facing gallery? Where is the public facing gallery hosted?

		- < https://www.myget.org/gallery/bonsai-community >

	- Saving videos and audios as non-default filetypes (anything besides .avi and .wav?; e.g. .mp3, .mp4)

		- < look up on google groups >

	- Creating comments/notes within workflow?

		- < group descriptions >

	- Specify sample rate for source (e.g. videocapture)

		- < "Format" property, "CaptureProperties - Property" property, "Property pages" (while running) >

	- `sum` outputs?

		- < by channel (BGRA) >

	- tell `zip` to stop if memory buffer gets too full?

		- < don't use zip in cases where this could happen >

	- `interval totalmilliseconds` vs. `interval milliseconds` ?

	- `FunctionGenerator` amp values? what bit representation?

	- for `PythonTransform` can you link to a file location rather than inputting code as text?

		- < not yet; instead, use import within code >

	- issues with `LessThan`

		- < takes the type of subscribed node upon initialization: does not change if subscribed node changes later on >

	- how to use `Crop` in closed loop worksheet exercise 6?

	- `RescaleType` linear vs. clamp?

		- Use `linear` when converting (e.g. pixels-to-metres)

	- `CameraCapture` vs `VideoCapture` ?

		- `CameraCapture` uses opencv, `VideoCapture` uses directshow

	- affine transforms?*

	- how are proper stream operations always ensured? (e.g. by transformers and combinators, how do we know we'll never miss an event?)

	- `Subsribe` vs. `Multicast` for Subjects?

		- `Multicast` acts as "on-next", `Subscribe` acts as source.

	- Can we use something besides `SelectMany` in exercise3 of state machines worksheet?

		- Yes, could use a group and `SubscribeWhen`.

	- `BitwiseNot` but no `LogicalNot` ?

		- < In C# you cannot use bitwise not for booleans, and you cannot use logical not for non-booleans. >

	- Why IronPython?

		- < It's .NETs implementations of Python >

	- Using `FileCapture` to view stream frame-by-frame?

	- add a `ParquetWriter`? in general process for adding new sources and sinks?

	- How to see source from which a Subject was created?

	- error handling?

		- < `Retry`; `Catch`; `Materialize` (`Kind`) -> `Condition` -> `Exception` >

	- testing workflows?

		- < Use dummy hardware Subjects using constants >

	- Is there a console where you can do stuff like print messages to screen?

	- Add `LogicalNot` as github issue?

	- Add elementwise math operators (e.g. `abs`) as github issue?

	- Automatically propagate name changes (e.g. changing a Subject name) throughout workflow?

	- Bonsai version control and package version control?

	- Scripting:

		- C#

			- <if> ? <then> : <else>

			- new type: `new(...)`

- Worksheet questions:

	- State Machines:

		- Exercise 1: Why use `BehaviorSubject` rather than `PublishSubject` for `DigitalInput` source Subject?

		- How to declare `LED_stim` (as Subject) at top level?

			- < Initialize as `BehaviorSubject` subscribed to some constant, then use as a `SubscribeSubject` and subscribe output to it. >

		- Exercise 2: Is there any point to using a Sink for StimOn and StimOff as opposed to just using a group or just leaving all nodes in top-level?

			-  < To play with side effects within sink easily, b/c input to sink will be output. >

	- Vision Psychophysics:

		- How does the `Angle` Subject (which gets assigned values between [-1, 1] map to the `Angle` property in `DrawGratings` (which takes angles in degrees?))

			- < This is specified as radians: gets converted to degrees under the hood. >

- Hotkey questions: