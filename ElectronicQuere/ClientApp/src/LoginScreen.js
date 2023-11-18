import React, { useState } from 'react';

import { useHistory } from 'react-router-dom/cjs/react-router-dom.min';

export const LoginScreen = () => {
  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');
  const history = useHistory();

  const handleLogin = () => {
    // Ваша логика для обработки входа
    // Например, отправка данных на сервер и проверка

    // Переход на другую страницу (после успешного входа)
    history.push('/'); // Замените '/main' на путь к странице после успешного входа
  };

  return (
    <div style={styles.container}>
      <h1 style={styles.title}>Вход</h1>
      <input
        style={styles.input}
        placeholder="Логин"
        value={username}
        onChange={(e) => setUsername(e.target.value)}
      />
      <input
        style={styles.input}
        placeholder="Пароль"
        type="password"
        value={password}
        onChange={(e) => setPassword(e.target.value)}
      />
      <button onClick={handleLogin}>Войти</button>
      <div style={{ marginTop: 10 }}>
        <span style={{ color: 'blue', cursor: 'pointer' }} onClick={() => history.push('/CreateAcc')}>
          Нет аккаунта? Зарегистрироваться
        </span>
      </div>
    </div>
  );
};

const styles = {
  container: {
    display: 'flex',
    flexDirection: 'column',
    justifyContent: 'center',
    alignItems: 'center',
    padding: 20,
  },
  title: {
    fontSize: 24,
    fontWeight: 'bold',
    marginBottom: 20,
  },
  input: {
    width: '50%',
    height: 40,
    marginBottom: 10,
    padding: 10,
  },
};

export default LoginScreen;
