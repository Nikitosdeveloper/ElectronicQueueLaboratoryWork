import React from 'react';

const Registrated = ({ navigation }) => {
  const phoneNumber = 'МТС  (33) 654-06-11';
  const telegramImage = require('./image/telegram.jpg');
  const handlePress = () => {
    // Действие по нажатию на ссылку Телеграма
  };

  return (
    <div style={{ flex: 1 }}>
      {/* Код для кнопки "Профиль" */}
      <div style={{ alignItems: 'flex-end', right: '7%', marginTop: 5 }}>
        <button onClick={() => navigation.navigate('Profile')}>
          <img
            src={require('./image/bsuir.png')} // Укажите путь к изображению профиля
            style={{ width: 50, height: 50 }}
            alt="BSUIR"
          />
        </button>
      </div>

      {/* Номер справочной и изображение Телеграма */}
      <div style={[styles.footerContainer, { backgroundColor: 'silver' }]}>
        <div>{phoneNumber}</div>
        <button onClick={handlePress}>
          <img src={telegramImage} style={styles.telegramImage} alt="Telegram" />
        </button>
      </div>
    </div>
  );
};

const styles = {
  footerContainer: {
    position: 'absolute',
    bottom: 0,
    width: '100%',
    display: 'flex',
    flexDirection: 'row',
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: '#f0f0f0', // Цвет фона для ясности
    padding: 10,
  },
  telegramImage: {
    width: 130,
    height: 50,
    marginLeft: 10,
  },
};

export default Registrated;
