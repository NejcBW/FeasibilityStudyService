var epwState;
var dsx;
var ctx = document.getElementById('myChart1').getContext('2d');
var myChart;

function foo() {
    fetch("https://localhost:5001/EPW")
        .then(response => response.json())
        .then(data => {
            epwState = data;
            dsx = data.data.map(p => ({ x: p.id, y: p.dryBulb }));
            myChart = chartLoad();
        })
        .catch(err => console.log("Something went wrong"));
}

function chartLoad() {

    var chart = new Chart(ctx, {
        type: 'scatter',
        data: {
            datasets: [{
                label: 'dataset 1',
                data: dsx
            }]
        },
        options: {}
    });

    return chart;

}

foo();




