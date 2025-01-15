function downloadFileFromBase64(base64Data, fileName) {
    // Создаем новый элемент <img>
    const imgElement = new Image();

    // Устанавливаем атрибут src для изображения с данными в формате Base64
    imgElement.src = `data:image/png;base64,${base64Data}`;

    // Добавляем изображение в контейнер с ID 'image-container'
    document.getElementById('image-container').appendChild(imgElement);


    const downloadLink = document.createElement('a');
    downloadLink.href = imgElement.src;
    downloadLink.download = fileName;  // Имя файла для скачивания

    // Программно вызываем клик на ссылку для начала скачивания
    downloadLink.click();
}