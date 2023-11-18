import React from 'react';
import { useHistory } from 'react-router-dom/cjs/react-router-dom.min';

const Main = () => {
  const phoneNumber = 'МТС  (33) 654-06-11';
  const telegramImage = require('./image/telegram.jpg');
  const navigate = useHistory()
  const handlePress = () => {
    // Действие по нажатию на ссылку Телеграма
  };

  return (
    <div style={{ position: 'relative', minHeight: '100vh' }}>
      {/* Остальной ваш контент здесь */}

      {/* Код для кнопки "Войти" */}
      <div style={{ position: 'absolute', top: '5%', right: '7%' }}>
        
          <button onClick={()=> navigate.push("/LoginScreen")}>Войти</button>
        
      </div>

      {/* Номер справочной и изображение Телеграма */}
      <div style={{ ...styles.footerContainer, backgroundColor: 'silver' }}>
        <span>{phoneNumber}</span>
        <button onClick={handlePress}>
        <img src={telegramImage.default} alt="Telegram" style={styles.telegramImage} />

        </button>
      </div>
    </div>
  );
};

const styles = {
  footerContainer: {
    width: '100%',
    display: 'flex',
    flexDirection: 'row',
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: '#f0f0f0',
    padding: 10,
    position: 'fixed',
    bottom: 0,
  },
  telegramImage: {
    width: 130,
    height: 50,
    marginLeft: 10,
  },
};

export default Main;
