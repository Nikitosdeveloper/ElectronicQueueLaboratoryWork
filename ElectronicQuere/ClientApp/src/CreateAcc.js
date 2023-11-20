import React, { useState } from 'react';
import axios from 'axios';

export const CreateAcc = ({ history }) => {
    const [username, setUsername] = useState('');
    const [password, setPassword] = useState('');

    const handleRegister = async () => {
        try {
            const registerUrl = 'https://localhost:44414/auth/login';

            const response = await axios.post(registerUrl, {
                username: username,
                password: password,
            });

            console.log('Успешная регистрация', response.data);

            // Переход на другую страницу (например, после успешной регистрации)
            history.push('/Registrated'); // Замените '/main' на путь к странице, на которую вы хотите перейти
        } catch (error) {
            console.error('Ошибка регистрации', error);
        }
    };

    return (
        <div style={styles.container}>
            <h1 style={styles.title}>Регистрация</h1>
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
            <button onClick={handleRegister}>Зарегистрироваться</button>
        </div>
    );
};

const styles = {
    container: {
        display: 'flex',
        flexDirection: 'column',
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

export default CreateAcc;
