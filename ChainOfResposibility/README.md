# Chain Of Responsibility

The Chain of Responsibility pattern works with a list of Handler objects that have
limitations on the nature of the requests they can deal with. If an object cannot handle
a request, it passes it on to the next object in the chain. At the end of the chain,
there can be either default or exceptional behavior.