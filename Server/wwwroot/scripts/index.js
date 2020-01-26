var epwState;
var dsx;

function foo() {
    var t0 = performance.now();
    fetch("https://localhost:5001/EPW")
        .then(response => response.json())
        .then(data => {
            epwState = data;
            dsx = data.data.map(p => ({ x: p.id, y: p.dryBulb }));
            var t1 = performance.now();
            var dt = t1 - t0;
            console.log("EPW fetching and loading time:" + dt)
        })
        .catch(err => console.log("Something went wrong"));
}

foo();




