# Singleton Design Pattern
The Singleton Design Pattern prevents a user from instantiating more than one object.  This can be very useful when multiple instances of a single class could be detrimental to the success of the class.

There are a few key giveaways to identify this type of design pattern:

* Private constructor
  * This prevents anyone, other than the class itself, from creating an instance of the class.
  * In languages that lack the ability to privatize the constructor, this will obviously be lacking from the design pattern.
* A "GetInstance" method
  * While it does not need to be this exact name, it's common to refer to the object as an Instance.
  * The function of the "GetInstance" method is to create the instance (if it does not exist) then return it.
  * This method will be static, so that it can be called without instantiating the class.

In this project's example, we're creating a Score Keeper, which will increment scores for players.  In the main program method, we're calling a separate function, which will interact with the Singleton, on our behalf.  Pay attention to the class implementation to see how the Singleton was achieved.  After each successful increment, we're printing the results to show that the class is, in fact being shared by the calls.

_Please feel free to make changes that correct errors_