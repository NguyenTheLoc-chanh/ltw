const btnAdd = document.querySelector(".add");
const btnCancel = document.querySelector(".cancel");

const tbl = document.querySelector("#table");
const tr = document.querySelector("tr");
const td = document.querySelector("td");

const txtNameVLX = document.querySelector("#nameVXL");
const txtHang = document.querySelector("#hang");
const txtDate = document.querySelector("#date");
const txtPrice = document.querySelector("#price");

const lbPrice = document.querySelector(".er_price");
 
// Còn lỗi check
function checkValue() {
    const name = txtNameVLX.value.trim();
    const hang = txtHang.value.trim();
    const date = txtDate.value.trim();
    const price = txtPrice.value.trim();

    const errorName = document.querySelector('.er_nameVXL');
    const errorHang = document.querySelector('.er_hang');
    const errorDate = document.querySelector('.er_date');
    const errorPrice = document.querySelector('.er_price');

    errorName.style.display = 'none';
    errorHang.style.display = 'none';
    errorDate.style.display = 'none';
    errorPrice.style.display = 'none';

    let valid = true;

    // Kiểm tra
    if (name === '') {
        errorName.style.display = 'block';
        valid = false;
    }

    if (hang === '') {
        errorHang.style.display = 'block';
        valid = false;
    }

    if (date === '') {
        errorDate.style.display = 'block';
        valid = false;
    } else {
        const currentDate = new Date();
        const inputDate = new Date(date);

        // Kiểm tra xem inputDate có hợp lệ không
        if (isNaN(inputDate.getTime())) {
            errorDate.textContent = 'Ngày không hợp lệ';
            errorDate.style.display = 'block';
            valid = false;
        } else if (inputDate > currentDate) {
            errorDate.textContent = 'Ngày không được là ngày trong tương lai';
            errorDate.style.display = 'block';
            valid = false;
        }
    }

    if (price === '') {
        errorPrice.style.display = 'block';
        valid = false;
    }

    return valid; // Trả về true hoặc false
}

function addContent(){
        const nameVXL = txtNameVLX.value.trim();
        const hang = txtHang.value.trim();
        const date = txtDate.value.trim();
        const price = txtPrice.value.trim();

        if(checkValue()){
            lbPrice.classList.remove("active");
            var trElement = document.createElement("tr");
            var tdSTT = trElement.appendChild(document.createElement("td"))
                                .classList.add("count");
            var tdName = trElement.appendChild(document.createElement("td"));
            var tdHang = trElement.appendChild(document.createElement("td"));
            var tdDate = trElement.appendChild(document.createElement("td"));
            var tdPrice = trElement.appendChild(document.createElement("td"));
    
            tdName.innerHTML = nameVXL;
            tdHang.innerHTML = hang;
            tdDate.innerHTML = date;
            tdPrice.innerHTML = price;
    
            tbl.appendChild(trElement);
        }
}

function onCancel(){
    txtNameVLX.value = "";
    txtHang.value = "";
    txtDate.value = "";
    txtPrice.value = "";
}
btnAdd.addEventListener("click", function(e){
    e.preventDefault();
    addContent();
});

btnCancel.addEventListener("click", function(e){
    e.preventDefault();
    onCancel();
})

