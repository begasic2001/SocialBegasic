import { useState,useEffect } from 'react'
import axios from "axios"
import {List, ListItem, ListItemText, Typography } from '@mui/material'
function App() {
  const [activities, setActivities] = useState<Activity[]>([]);

  useEffect(() => {
      axios.get<Activity[]>('https://localhost:5000/api/Activity')
      .then(response => setActivities(response.data))
      return () => {}
  }, [])

  return (
   
    <>
      <Typography variant='h3'>Social</Typography>
      <List>
        {activities.map((activity) => (
          <ListItem key={activity.id}>
            <ListItemText>{activity.title}</ListItemText>
          </ListItem>
        ))}
      </List>
    </>
    
  )
}

export default App
