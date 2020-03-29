const runCsharp = (a, b) => {
    console.warn("runCsharp is executing");
    //invokeResult是Task序列化的结果
    let invokeResult = DotNet.invokeMethod("BlazorInterop", "Sum", a, b);
    if (invokeResult.isCompletedSuccessfully) {
        return invokeResult.result;
    }
    return -1;
};

window.interop = {
    runJs: (name, a, b) => {
        console.warn("runJs is executing");
        console.warn("hello " + name);
        return "OK " + runCsharp(a, b);
    },

    runJs2: (objInstance, a, b) => {
        let invokeResult = objInstance.invokeMethod("Multiply", a, b);
        console.warn(invokeResult);
        return "OK:" + invokeResult;
    }
}