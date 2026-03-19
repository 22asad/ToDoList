import { useEffect, useState } from 'react';

function App() {
  const [tasks, setTasks] = useState([]);

  useEffect(() => {
    fetch('https://reimagined-funicular-xqr4rrx6vv636q55-5074.app.github.dev/api/task')
      .then(res => res.json())
      .then(data => {
        console.log(data); 
        setTasks(data); // <--- ADD THIS LINE TO UPDATE THE UI
      })
      .catch(err => console.error("Fetch error:", err));
  }, []);

  return (
    <div style={{ padding: "20px" }}>
      <h1>My Tasks</h1>
      {tasks.length === 0 ? (
        <p>Loading tasks...</p>
      ) : (
        tasks.map(t => (
          <p key={t.id}>
            {t.title} - {t.isCompleted ? "✅" : "❌"}
          </p>
        ))
      )}
    </div>
  );
}

export default App;
