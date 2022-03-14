const api_url = "https://localhost:44310/api/All/getCatData";
var tags = [
    "Delhi",
    "Ahemdabad",
    "Punjab",
    "Uttar Pradesh",
    "Himachal Pradesh",
    "Karnatka",
    "Kerela",
    "Maharashtra",
    "Gujrat",
    "Rajasthan",
    "Bihar",
    "Tamil Nadu",
    "Haryana"
];

async function getapi(url) {
    const response = await fetch(url);
    var data = await response.json();
    console.log(data);
    tags = data;
    if (response) {
        hideloader();
    }
    show(data);
}


/*function hideloader() {
    document.getElementById('loading').style.display = 'none';
}*/

function show(data) {
    var tab = "";
    data.map(datas => {
        tab = tab + "<option value=" + datas + "></option>";
    });
    alert(tab);
    document.getElementById("datalist").innerHTML = tab;
}


getapi(api_url);

var n = tags.length; 

function ac(value) {
    document.getElementById('datalist').innerHTML = '';
    l = value.length;
    for (var i = 0; i < n; i++) {
        if (((tags[i].toLowerCase()).indexOf(value.toLowerCase())) > -1) {
            var node = document.createElement("option");
            var val = document.createTextNode(tags[i]);
            node.appendChild(val);
            document.getElementById("datalist").appendChild(node);
        }
    }
}