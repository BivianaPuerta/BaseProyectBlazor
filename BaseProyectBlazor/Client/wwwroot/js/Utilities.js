  function testPointNetStatic() {
      DotNet.invokeMethodAsync("BaseProyectBlazor.Client", "GetCurrentCount")
        .then(result => {
            console.log("conteo desde javascript" + result);
        });
} 

function testPointNETInstancia(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}