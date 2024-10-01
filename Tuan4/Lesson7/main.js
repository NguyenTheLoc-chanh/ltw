const ddlDanhSachHang = document.getElementById("ddlDanhsachhangsx");
const btnAdd = document.querySelector(".add");
const btnSave = document.querySelector(".save");
const btnCancel = document.querySelector(".cancel");
const lblhang = document.querySelector(".lblHang");
const txtHang = document.querySelector("#txtHang");
const divHang = document.querySelector(".hang");
const lblError = document.querySelector("#tb");

const brands = ["Intel","ADM","SamSung"];

function render(){
    for(let i=0; i< brands.length; i++){
        const option = document.createElement("option");
        option.text = brands[i].trim();
        option.value = brands[i].toLowerCase();
        ddlDanhSachHang.appendChild(option);
    }
}

render();

btnAdd.addEventListener("click", function(e){
    e.preventDefault();
    divHang.classList.add("active");
    btnSave.classList.add("active");
    btnAdd.classList.add("inactive");
})

function onCancel(){
    ddlDanhSachHang.innerHTML ="";
    txtHang.value = "";
    lblError.style.display = "none";
    render();
    divHang.classList.remove("active");
    btnSave.classList.remove("active");
    btnAdd.classList.remove("inactive");
}

btnSave.addEventListener("click", function(e){
    e.preventDefault();
    if(txtHang.value === ""){
        lblError.style.display = "block";
        txtHang.focus();
    }else{
        lblError.style.display = "none";
        //Phương thức này tạo một mảng mới bằng cách áp dụng hàm cho từng phần tử trong mảng brands
        if(brands
            .map((value) => value.toLowerCase())
            .indexOf(txtHang.value.trim())=== -1 
            && brands.indexOf(txtHang.value.trim())=== -1){
                brands.push(txtHang.value.trim());
                onCancel();
            }else{
                lblError.innerHTML = "Không thể lưu vì trùng lặp giá trị!";
                txtHang.focus();
            }
    }
});

btnCancel.addEventListener("click", function(e){
    e.preventDefault();
    onCancel();
})