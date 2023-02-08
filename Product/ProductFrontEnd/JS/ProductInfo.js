

const url = "http://localhost:54997/api/Product";
function LoadProduct() {
    alert("shrusti")
    $("table").find("tr:gt(0)").remove();
    $.get(url, (data)=> {
        for (const item of data) {
            const row = `<tr><td>${item.ProductId}</td><td> ${item.ProductName}</td><td>${item.Quantity}</td><td><a href="#" onclick="OnDisplay(${item.ProductId})">View</a>&nbsp<a href="#" onclick="Delete(${item.ProductId})">Delete</a></td></tr> `
            $("table").append(row);
        }
    })
}

function OnDisplay(id) {
    const tempUrl = url + "/" + id;
    $.get(tempUrl, (data) => {
        $("#txtId").val(data.ProductId);
        $("#txtName").val(data.ProductName);
        $("#txtPrice").val(data.ProductPrice);
        $("#txtQuantity").val(data.Quantity);
        $("#image").attr("src", `http://localhost:54997/${data.ProductImage}`)
    })
}

function UpdateRecord() {
    let obj = {}
    obj.ProductId = $("#txtId").val();
    obj.ProductName = $("#txtName").val();
    obj.ProductPrice = $("#txtPrice").val();
    obj.Quantity = $("#txtQuantity").val();
    let src = $("#image").attr("src");
    let modified = src.replace("http://localhost:54997/", "");
    alert(modified);
    //debugger;
    obj.ProductImage = modified;
    $.ajax({
        'url': url,
        'data': obj,
        'success': function () { LoadProduct(); },
        'method': 'PUT'
    });
}

function AddRecord(){
    let obj = {}
    obj.ProductName = $("#txtName").val();
    obj.ProductPrice = $("#txtPrice").val();
    obj.Quantity = $("#txtQuantity").val();
    obj.ProductImage = "../../desktop.jfif";
    $.ajax({
        'url': url,
        'data': obj,
        'success': function () { LoadProduct(); },
        'method': 'POST'
    });
}

function init() {
    $("a:first").click(LoadProduct);
    $("#btnUpdate").click(UpdateRecord);
    $("#btnAdd").click(AddRecord);
}
$().ready(init)
