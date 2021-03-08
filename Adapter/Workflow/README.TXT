
# 原程序功能说明：

1、已知旧程序中已经支持Workflow 3（由于Workflow 3是旧代码，为了不影响原有功能，所以不能直接修改Workflow 3代码，即WF3文件夹文件），而现在我们已经开发出Workflow 4，且按规定已满足接口规范IWorkflow。


# 新程序改造要求：

1、新代码WF4的调用方式与WF3不兼容，我们在实例化时，需要区别对待，如Program.ConsoleResponse中的例子。请为WF3增加Adapter，改造代码使之更符合面向对象规范。

2、请使用IOC框架Unity，优化实例化方式。
