import React from 'react';

const ProfileScreen = () => {
  // Замените этот фиктивный пользовательской информацией
  const user = {
    username: 'Имя_Студента',
    status: 'Студент',
  };

  // Замените этот фиктивным списком предстоящих лабораторных работ
  const upcomingLabWorks = [
    { title: 'Лабораторная работа 1', date: '10 сентября 2023' },
    { title: 'Лабораторная работа 2', date: '17 сентября 2023' },
    // Другие предстоящие лабораторные работы
  ];

  // Замените этот фиктивным списком сданных работ
  const completedLabWorks = [
    { title: 'Лабораторная работа 3', date: '3 сентября 2023' },
    { title: 'Лабораторная работа 4', date: '5 сентября 2023' },
    // Другие сданные лабораторные работы
  ];

  return (
    <div style={styles.container}>
      <div style={styles.username}>{user.username}</div>
      <div style={styles.status}>{user.status}</div>

      <div style={styles.sectionTitle}>Предстоящие лабораторные работы:</div>
      {upcomingLabWorks.map((labWork, index) => (
        <div key={index} style={styles.labWorkItem}>
          <div>{labWork.title}</div>
          <div>{labWork.date}</div>
        </div>
      ))}

      <div style={styles.sectionTitle}>Сданные лабораторные работы:</div>
      {completedLabWorks.map((labWork, index) => (
        <div key={index} style={styles.labWorkItem}>
          <div>{labWork.title}</div>
          <div>{labWork.date}</div>
        </div>
      ))}

      {/* Добавьте кнопки для дополнительных действий, например, выход из профиля */}
      <button >Выйти</button>
    </div>
  );
};

const styles = {
  container: {
    padding: 16,
  },
  username: {
    fontSize: 24,
    fontWeight: 'bold',
  },
  status: {
    fontSize: 16,
    marginBottom: 10,
  },
  sectionTitle: {
    fontSize: 18,
    fontWeight: 'bold',
    marginTop: 10,
  },
  labWorkItem: {
    display: 'flex',
    flexDirection: 'row',
    justifyContent: 'space-between',
    marginBottom: 8,
  },
};

export default ProfileScreen;
